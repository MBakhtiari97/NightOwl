﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Core.Services.Interfaces
{
    public interface IGalleryRepository
    {
        IEnumerable<Galleries> GetItemGalleryByItemId(int itemId);
    }
}
