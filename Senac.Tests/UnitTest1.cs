namespace Senac.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Login_EmailSenhaCorretos()
    {
        Usuario usuario = new Usuario();
        var resultado = usuario.Login("milena.madeira@alunos.sc.senac.br", "123456");
        Assert.AreEqual("Usuário logado", resultado);
    }

    [TestMethod]
    public void Login_EmailIncorreto()
    {
        Usuario usuario = new Usuario();
        var resultado = usuario.Login("marcelo.petri@senac.br", "123456");
        Assert.AreEqual("E-mail ou senha incorretos", resultado);
    }


    [TestMethod]
    public void Login_SenhaIncorreto()
    {
        Usuario usuario = new Usuario();
        var resultado = usuario.Login("marcelo.petri@prof.sc.senac.br", "123456");
        Assert.AreEqual("E-mail ou senha incorretos", resultado);
    }

    [TestMethod]
    public void Login_SenhaVazia()
    {
        Usuario usuario = new Usuario();
        var resultado = usuario.Login("milena.madeira@alunos.sc.senac.br", "");
        Assert.AreEqual("Preencha todos os dados!", resultado);
    }

    [TestMethod]
    public void Login_EmailVazio()
    {
        Usuario usuario = new Usuario();
        var resultado = usuario.Login("", "123456");
        Assert.AreEqual("Preencha todos os dados!", resultado);
    }

    [DataTestMethod]
    [DataRow("")]
    [DataRow(null)]
    public void VerificarNome_RetornoFalso(string value)
    {
        Usuario usuario = new Usuario();
        var resultado = usuario.VerificarNome(value);
        Assert.IsFalse(resultado);
    }
}