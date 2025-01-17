﻿using FluentValidator;
using System;

namespace CBERS.Domain.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        protected Entity(Guid id)
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
