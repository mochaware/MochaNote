﻿/*
 * Copyright (c) 2007-2012, Masahiko Kamo (mkamo@mkamo.com).
 * All Rights Reserved.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mkamo.Editor.Core;
using Mkamo.Figure.Core;
using System.Drawing;

namespace Mkamo.Editor.Requests {
    public class NewEdgePointRequest: AbstractRequest {
        // ========================================
        // field
        // ========================================
        public EdgePointRef PrevEdgePointRef;
        public Point Location;

        // ========================================
        // property
        // ========================================
        public override string Id {
            get { return RequestIds.NewEdgePoint; }
        }
    }
}
