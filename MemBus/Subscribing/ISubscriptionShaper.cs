﻿using System;

namespace MemBus.Subscribing
{
    /// <summary>
    /// This interface describes some type that typically wraps a given <see cref="ISubscription"/>-instance with some new behaviour.
    /// Implementations readily available are:
    /// - <see cref="ShapeToDispose"/>
    /// - <see cref="ShapeToFilter{M}"/>
    /// - <see cref="ShapeToUiDispatch"/>
    /// - <see cref="SubscriptionCustomizer{M}"/>
    /// </summary>
    public interface ISubscriptionShaper
    {
        /// <summary>
        /// The contract to implement as subscription shaper
        /// </summary>
        ISubscription EnhanceSubscription(ISubscription subscription);
    }
}