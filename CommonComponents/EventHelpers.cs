﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonComponents
{
    public static class EventHelpers
    {
        public static void RaiseEvent(Object objectRaisingEvent,
            EventHandler<AccessTypeEventArgs> eventHandlerRaised,
            AccessTypeEventArgs accessTypeEventArgs)
        {
            if (eventHandlerRaised != null) //check if any subscribed
            {
                eventHandlerRaised(objectRaisingEvent, accessTypeEventArgs);
            }
        }

        public static void RaiseEvent(Object objectRaisingEvent,
            EventHandler eventHandlerRaised,
            EventArgs eventArgs)
        {
            if (eventHandlerRaised != null) //check if any subscribed
            {
                eventHandlerRaised(objectRaisingEvent, eventArgs);
            }
        }
    }
}
