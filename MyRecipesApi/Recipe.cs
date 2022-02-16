namespace MyRecipesApi
{
    public class Recipe
    {
        //Atributo (campo de la clase. Siempre en minúscula y con _, privado)
        //Propiedad {get;} en mayúscula y pública, acceder desde fuera). Encapsulación y accesibilidad.
        private readonly string _name;
        public Recipe(string name)
        {
            _name = name;
        }

        protected bool Equals(Recipe other)
        {
            return _name == other._name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Recipe) obj);
        }

        public override int GetHashCode()
        {
            return (_name != null ? _name.GetHashCode() : 0);
        }

        public override string ToString()
        {
            return $"{nameof(_name)}: {_name}";
        }
    }
}