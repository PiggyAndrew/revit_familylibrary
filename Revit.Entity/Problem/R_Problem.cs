using Microsoft.EntityFrameworkCore;
using Revit.Entity.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Problem
{
    public class R_Problem : R_Entity
    {
        [Comment("相关文件Id")]
        [Required]
        public long RelativeFileId { get; set; }

        [Comment("紧急程度")]
        [Required]
        public EmergencyDegree EmergencyDegree { get; set; }

        [Comment("问题描述")]
        [MaxLength(500)]
        public string Discription { get; set; }

        [Comment("截止日期")]
        public DateTime Deadline { get; set; }

        [Comment("问题状态")]
        public ProblemStatus ProblemStatus { get; set; }=ProblemStatus.Dealing;

        [Comment("责任人Id")]
        [Required]
        public long ResponsibleId { get; set; }

        [Comment("审核人Id")]
        [Required]
        public long VerifierId { get; set; }


    }

    public enum ProblemStatus
    { 
      Closed = 0,
      Dealing = 1,
      WaitingForReview = 2,
      Resolved = 3,
    }


    public enum EmergencyDegree
    {
        Urgency,
        Normal,
    }
}
