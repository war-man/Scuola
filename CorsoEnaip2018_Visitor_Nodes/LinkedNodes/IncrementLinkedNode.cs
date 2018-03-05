﻿using System;
using CorsoEnaip2018_Visitor_Nodes.Visitors;

namespace CorsoEnaip2018_Visitor_Nodes.LinkedNodes
{
    class IncrementLinkedNode : LinkedNode
    {
        public double Increment { get; set; }

        public override void Accept(ILinkedNodeVisitor v)
        {
            v.Visit(this);

            if (Next != null)
                Next.Accept(v);
        }
    }
}
