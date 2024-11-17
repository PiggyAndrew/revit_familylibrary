using Revit.Entity.Commons;
using Revit.Entity.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Revit.Entity.Family
{
    public class R_FamilyUser : R_Entity
    {
        /// <summary>
        /// ½ÇÉ«Id
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// ²Ëµ¥Id
        /// </summary>
        public long FamilyId { get; set; }


    }
}