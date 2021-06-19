using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.AccessControl;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using TheGigHub.Dtos;
using TheGigHub.Models;

namespace TheGigHub.Controllers
{
    [Authorize]
    public class FollowController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public FollowController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto dto)
        {
            var userId = User.Identity.GetUserId();

            if (_context.FollowArtists.Any(a => a.FollowedId == userId && a.FollowedId == dto.FolloweeId))
                return BadRequest("Following already exist");


            var following = new FollowArtists()
            {
                FollowerId = userId,
                FollowedId = dto.FolloweeId

            };
            _context.FollowArtists.Add(following);
            _context.SaveChanges();

            return Ok();
        }
    }
}
