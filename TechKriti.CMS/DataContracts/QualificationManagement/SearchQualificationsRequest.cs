﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Datacontracts.QualificationManagement
{
    [DataContract]
    public class SearchQualificationsRequest
    {
        [DataMember]
        public QualificationSearchDataContract Filter { get; set; }
    }
}
