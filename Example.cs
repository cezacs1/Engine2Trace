    // Example:
    
        public override void TraceRay(Ray ray, TraceType_t type, TraceFilter pTraceFilter, float DefaultDamage, int pIndex, out Vector2 TraceLine)
        {
            TraceLine = default;

            var start = ray.start;
            var end = ray.end;

            float distance = Vector2.Distance(end, start);
            int pointCount = (int)distance + 1;

            switch (type)
            {
                case TraceType_t.TRACE_WORLD_ONLY:
                    for (int i = 0; i < pointCount; i++)
                    {
                        float t = (float)i / (float)(pointCount - 1);
                        Vector2 point = Vector2.Lerp(start, end, t);

                        if (DidHitWorld(point) == false)
                        {
                            //MessageBox.Show("çarptı -> " + point);
                            return;
                        }

                        Console.WriteLine("point: " + point);

                    }
                    break;

                case TraceType_t.TRACE_ENTITIES_ONLY:
                    for (int i = 0; i < pointCount; i++)
                    {
                        float t = (float)i / (float)(pointCount - 1);
                        Vector2 point = Vector2.Lerp(start, end, t);

                        if (IsVisible(ray, pIndex) == false)
                        {
                            //MessageBox.Show("çarptı -> " + point);
                            return;
                        }

                        Console.WriteLine("point: " + point);

                    }
                    break;


            }


            return;
        }
