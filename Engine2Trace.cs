// SOURCE 2 [Counter-Strike 2 Engine] Trace

    public class EngineTrace
    {
        public virtual void TraceRay(Ray ray, TraceType_t type, TraceFilter pTraceFilter, float DefaultDamage, int pIndex, out Vector2 TraceLine) { TraceLine = default; return; } 

        public virtual bool IsVisible(Ray ray, int index) => Visible(index, ray.start, ray.end);

        public virtual bool Visible(int index, Vector2 start, Vector2 end)
        {
            return false;
        }

        public virtual float DidHitEntity(int PlayerIndex, Vector2 start, Vector2 end)
        {
            return 0;
        }

        public virtual bool DidHitWorld(Vector2 point)
        {
            return false;
        }

    }
