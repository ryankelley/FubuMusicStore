﻿using System;
using FubuFastPack.Domain;

namespace FubuMusicStore.Domain
{
    public class Cart : DomainEntity
    {
        public virtual int RecordId { get; set; }
        public virtual string CartId { get; set; }
        public virtual int Count { get; set; }
        public virtual DateTime DateCreated { get; set; }

        public virtual Album Album { get; set; }
    }
}