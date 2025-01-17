﻿using System;

namespace ExRam.Gremlinq.Core
{
    public interface IChooseBuilderWithCase<out TSourceQuery, in TElement, TTargetQuery> : IChooseBuilderWithCaseOrDefault<TTargetQuery>
        where TSourceQuery : IGremlinQuery where TTargetQuery : IGremlinQuery
    {
        IChooseBuilderWithCase<TSourceQuery, TElement, TTargetQuery> Case(TElement element, Func<TSourceQuery, TTargetQuery> continuation);
        IChooseBuilderWithCaseOrDefault<TTargetQuery> Default(Func<TSourceQuery, TTargetQuery> continuation);
    }
}
