using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace TRANQUOCKHANH_LAP456_BIGSCHOOL.Models
{
    public class Following
    {
        [key]
        [Column(Order = 1)]
        public string FollowerId { get; set; }

        [key]
        [Column(Order = 2)]
        public string FolloweeId {get; set; }

        public ApplicationUser Follower { get; set; }
        public ApplicationUser Followee { get; set; }
    }
}