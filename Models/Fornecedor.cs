namespace LHPet;

public class Fornecedor
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cnpj { get; set; }
    public String? Email { get; set; }


    public Fornecedor(int id, string? name, string Cnpj, string? email)
    {
        this.Id = id;
        this.Nome = name;
        this.Cnpj = Cnpj;
        this.Email = email;
        
        
    }
}