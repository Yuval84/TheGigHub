using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheGigHub.Models
{
    public class FollowArtists
    {
        public ApplicationUser Follower { get; set; }
        public ApplicationUser Followed { get; set; }

        [Key]
        [Column(Order = 2)]
        public string FollowerId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string FollowedId { get; set; }
    }
}