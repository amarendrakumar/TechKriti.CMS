﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Datacontracts.PhotoGalleryManagement
{
    [DataContract]
    public class DeletePhotoGalleryRequest
    {
        [DataMember]
        public int PhotoGalleryID { get; set; }
    }
}
