using Plot.WebAPI.Models;

namespace Plot.WebAPI.DTO;

public class UsuarioRespostaDTO(int idUsuario, string Nome, string Email, string TipoUsuario, bool Ativo, string? FotoPerfil)
{
    public static UsuarioRespostaDTO Converter(Usuario usuario) => new UsuarioRespostaDTO(
        usuario.IdUsuario,
        usuario.Nome,
        usuario.Email,
        usuario.TipoUsuario,
        usuario.Ativo,
        usuario.FotoPerfil
    );
}
