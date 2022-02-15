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
    }
}