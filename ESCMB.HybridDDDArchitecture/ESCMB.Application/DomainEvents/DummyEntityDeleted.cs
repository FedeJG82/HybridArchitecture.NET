﻿using Core.Application;

namespace ESCMB.Application.DomainEvents
{
    internal sealed class DummyEntityDeleted : DomainEvent
    {
        public int DummyIdProperty { get; set; }

        public DummyEntityDeleted(int id)
        {
            DummyIdProperty = id;
        }
    }
}
