#pragma warning disable CS0169, CS0649 // unused fields

namespace Chr.Avro.Tests
{
    public interface IEmptyInterface { }

    public class EmptyClass { }

    public struct EmptyStruct { }

    public interface IVisibilityInterface
    {
        int PublicProperty { get; }
    }

    public class VisibilityClass
    {
        public int PublicField;

        internal int InternalField;

        protected int ProtectedField;

        private int PrivateField;

        public int PublicProperty { get; set; }

        internal int InternalProperty { get; set; }

        protected int ProtectedProperty { get; set; }

        private int PrivateProperty { get; set; }

        public static int PublicStaticField;

        internal static int InternalStaticField;

        protected static int ProtectedStaticField;

        private static int PrivateStaticField;

        public static int PublicStaticProperty { get; set; }

        internal static int InternalStaticProperty { get; set; }

        protected static int ProtectedStaticProperty { get; set; }

        private static int PrivateStaticProperty { get; set; }
    }

    public class CircularClass
    {
        public CircularClass Child { get; set; }
    }

    public class CircularClassA
    {
        public CircularClassB B { get; set; }
    }

    public class CircularClassB
    {
        public CircularClassA A { get; set; }
    }
}