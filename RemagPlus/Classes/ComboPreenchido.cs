public class ComboPreenchido
{
    public ComboPreenchido()
    { }

    private int _codigo;
    private string _descricao;
    private string _nome;
    public ComboPreenchido(int codigo, string descricao)
    {
        this._codigo = codigo;
        this._descricao = descricao;
    }

    public ComboPreenchido(string nome, string titulo)
        : this(0, null)
    {
        this._nome = nome;
        this._descricao = titulo;
    }
    public int Codigo
    {
        get { return _codigo; }
    }

    public string Nome
    {
        get { return _nome; }
    }
    public string Descricao
    {
        get { return _descricao; }
    }

    public override string ToString()
    {
        return this._descricao;
    }
}