using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBuilder
{
    public interface GorillaScreen
    {
        public string Title { get; }
        public string Description { get; }
        public static void Save() { }
    }
}