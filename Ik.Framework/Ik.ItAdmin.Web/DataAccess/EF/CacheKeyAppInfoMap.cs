﻿using Ik.Framework.DataAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ik.ItAdmin.Web.DataAccess.EF
{
    public class CacheKeyAppInfoMap : IkEntityTypeConfiguration<CacheKeyAppInfoEntity>
    {
        public CacheKeyAppInfoMap()
        {
            this.ToTable("cache_key_app_info");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasColumnName("app_id");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.Code).HasColumnName("code");
            this.Property(t => t.Desc).HasColumnName("desc");

            this.Property(t => t.CreateTime).HasColumnName("create_time");
        }
    }
}