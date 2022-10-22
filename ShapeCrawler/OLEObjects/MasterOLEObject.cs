﻿using ShapeCrawler.Placeholders;
using ShapeCrawler.Shapes;
using ShapeCrawler.SlideMasters;
using P = DocumentFormat.OpenXml.Presentation;

namespace ShapeCrawler.OLEObjects;

internal class MasterOLEObject : MasterShape, IShape
{
    internal MasterOLEObject(SCSlideMaster slideMasterInternal, P.GraphicFrame pGraphicFrame)
        : base(pGraphicFrame, slideMasterInternal)
    {
    }

    public override IPlaceholder? Placeholder => MasterPlaceholder.Create(this.PShapeTreesChild);

    public override SCShapeType ShapeType => SCShapeType.OLEObject;
}