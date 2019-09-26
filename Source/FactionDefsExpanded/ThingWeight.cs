﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace D9Extended
{
    class ThingWeight
    {
        public ThingDef def;
        public float weight, weightMale, weightFemale;

        public ThingWeight(ThingDef d, float w)
        {
            def = d;
            weight = w;
            weightMale = -1;
            weightFemale = -1;
        }

        public ThingWeight(ThingDef d, float wm, float wf)
        {
            def = d;
            weightMale = wm;
            weightFemale = wf;
            weight = (wm + wf) / 2;
        }
    }
}