namespace FreeAccessLibrary.Data
{
    public class YasoParameter
    {
        public string Name { get; set; }

        public object Value { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is YasoParameter)
            {
                YasoParameter yp = obj as YasoParameter;
                if (this.Name.Equals(yp.Name))
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}