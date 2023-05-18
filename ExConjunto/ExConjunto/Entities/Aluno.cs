namespace ExConjunto.Entities
{
    internal class Aluno
    {
        public int Id { get; set; }

        public Aluno(int id)
        {
            Id = id;
        }
        
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Aluno))
            {
                return false;
            }

            Aluno other = obj as Aluno;
            return Id.Equals(other.Id);

        }
    }
}
