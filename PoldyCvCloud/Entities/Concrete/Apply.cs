﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Apply:IEntity
    {
        public int ApplyId { get; set; }
        public int PersonId { get; set; }
        public int TitleId { get; set; }
        public int DepartmentId { get; set; }
        public int JobAdverrisementId { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public byte Pdf { get; set; }
    }
}