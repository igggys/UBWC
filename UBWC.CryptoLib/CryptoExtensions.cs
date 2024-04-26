using Microsoft.Extensions.DependencyInjection;

namespace UBWC.CryptoLib
{
    public static class CryptoExtensions
    {
        public static void AddCrypto(this IServiceCollection services)
        {
            services.AddSingleton<AsymmetricEncryption>();
            services.AddSingleton<SymmetricEncryption>();
        }
    }
}
