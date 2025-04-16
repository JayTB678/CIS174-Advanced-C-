using Xunit;
using Microsoft.AspNetCore.Mvc;
using TicketApplication.Controllers;
using TicketApplication.Models;
using Moq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using TicketApplication.Repository;
namespace TicketsTest
{
    public class HomeControllerTests
    {
        private List<TicketStatus> GetFakeStatuses() => new List<TicketStatus>()
        {
            new TicketStatus { Id = 1, Name = "To Do" },
            new TicketStatus { Id = 2, Name = "In Progress" },
        };

        private List<Ticket> GetFakeTickets() => new List<Ticket>()
        {
            new Ticket { Id = 1, Name = "Test Ticket 1", Description = "Description 1", SprintNumber = 1, PointValue = 3, TicketStatusId = 1 },
            new Ticket { Id = 2, Name = "Test Ticket 2", Description = "Description 2", SprintNumber = 2, PointValue = 5, TicketStatusId = 2 },
        };

        [Fact]
        public void Index_ViewWithTickets()
        {
            var mockRepo = new Mock<ITicketRepository>();
            mockRepo.Setup(repo => repo.GetAll()).Returns(GetFakeTickets());

            var ctrl = new HomeController(mockRepo.Object);
            var res = ctrl.Index();

            var viewResult = Assert.IsType<ViewResult>(res);
            var model = Assert.IsAssignableFrom<List<Ticket>>(viewResult.Model);
            Assert.Equal(2, model.Count);
        }

        [Fact]
        public void Add_Get_ViewWithStatus()
        {
            var mockRepo = new Mock<ITicketRepository>();
            mockRepo.Setup(repo => repo.GetStatuses()).Returns(GetFakeStatuses());
            
            var ctrl = new HomeController(mockRepo.Object);
            var res = ctrl.Add();

            var viewResult = Assert.IsType<ViewResult>(res);
            Assert.IsType<SelectList>(viewResult.ViewData["Statuses"]);
        }

        [Fact]
        public void Add_Post_RedirectToIndex()
        {
            var mockRepo = new Mock<ITicketRepository>();
            var ctrl = new HomeController(mockRepo.Object);

            var ticket = new Ticket
            {
                Name = "Test Ticket",
                Description = "Test Description",
                SprintNumber = 1,
                PointValue = 3,
                TicketStatusId = 1
            };
            var res = ctrl.Add(ticket);

            var redirectResult = Assert.IsType<RedirectToActionResult>(res);
            Assert.Equal("Index", redirectResult.ActionName);
            mockRepo.Verify(repo => repo.Add(It.IsAny<Ticket>()), Times.Once);
        }

        [Fact]
        public void Edit_Get_ReturnsTicketView()
        {
            var ticket = GetFakeTickets()[0];
            var mockRepo = new Mock<ITicketRepository>();
            mockRepo.Setup(repo => repo.GetById(1)).Returns(ticket);
            mockRepo.Setup(repo => repo.GetStatuses()).Returns(GetFakeStatuses());

            var ctrl = new HomeController(mockRepo.Object);
            var res = ctrl.Edit(1);

            var viewResult = Assert.IsType<ViewResult>(res);
            var model = Assert.IsType<Ticket>(viewResult.Model);
            Assert.Equal(1, model.Id);
        }

        [Fact]
        public void Delete_Post_DeletesTicketAndRedirect()
        {
            var ticket = GetFakeTickets()[0];
            var mockRepo = new Mock<ITicketRepository>();

            var ctrl = new HomeController(mockRepo.Object);
            var res = ctrl.Delete(ticket);

            var redirect = Assert.IsType<RedirectToActionResult>(res);
            Assert.Equal("Index", redirect.ActionName);
            mockRepo.Verify(repo => repo.Delete(ticket.Id), Times.Once);
        }
    }
}