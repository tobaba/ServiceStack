// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HelloArrayOperations.
    /// </summary>
    public static partial class HelloArrayOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static IList<ArrayResult> Get(this IHelloArrayOperations operations, IList<string> names = default(IList<string>), HelloArray body = default(HelloArray))
            {
                return operations.GetAsync(names, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ArrayResult>> GetAsync(this IHelloArrayOperations operations, IList<string> names = default(IList<string>), HelloArray body = default(HelloArray), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(names, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static IList<ArrayResult> Create(this IHelloArrayOperations operations, IList<string> names = default(IList<string>), HelloArray body = default(HelloArray))
            {
                return operations.CreateAsync(names, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ArrayResult>> CreateAsync(this IHelloArrayOperations operations, IList<string> names = default(IList<string>), HelloArray body = default(HelloArray), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(names, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static IList<ArrayResult> Post(this IHelloArrayOperations operations, IList<string> names = default(IList<string>), HelloArray body = default(HelloArray))
            {
                return operations.PostAsync(names, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ArrayResult>> PostAsync(this IHelloArrayOperations operations, IList<string> names = default(IList<string>), HelloArray body = default(HelloArray), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(names, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static IList<ArrayResult> Delete(this IHelloArrayOperations operations, IList<string> names = default(IList<string>), HelloArray body = default(HelloArray))
            {
                return operations.DeleteAsync(names, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ArrayResult>> DeleteAsync(this IHelloArrayOperations operations, IList<string> names = default(IList<string>), HelloArray body = default(HelloArray), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(names, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
