using System.Threading.Tasks;
using edjCase.JsonRpc.Client;
using edjCase.JsonRpc.Core;
using RPCRequestResponseHandlers;

namespace Nethereum.RPC.Eth.Mining
{

    ///<Summary>
       /// eth_submitWork
/// 
/// Used for submitting a proof-of-work solution.
/// 
/// Parameters
/// 
/// DATA, 8 Bytes - The nonce found (64 bits)
/// DATA, 32 Bytes - The header's pow-hash (256 bits)
/// DATA, 32 Bytes - The mix digest (256 bits)
/// params: [
///   "0x0000000000000001",
///   "0x1234567890abcdef1234567890abcdef1234567890abcdef1234567890abcdef",
///   "0xD1FE5700000000000000000000000000D1FE5700000000000000000000000000"
/// ]
/// Returns
/// 
/// Boolean - returns true if the provided solution is valid, otherwise false.
/// 
/// Example
/// 
///  Request
/// curl -X POST --data '{"jsonrpc":"2.0", "method":"eth_submitWork", "params":["0x0000000000000001", "0x1234567890abcdef1234567890abcdef1234567890abcdef1234567890abcdef", "0xD1GE5700000000000000000000000000D1GE5700000000000000000000000000"],"id":73}'
/// 
///  Result
/// {
///   "id":1,
///   "jsonrpc":"2.0",
///   "result": true
/// }    
    ///</Summary>
    public class EthSubmitWork : RpcRequestResponseHandler<bool>
        {
            public EthSubmitWork(RpcClient client) : base(client,ApiMethods.eth_submitWork.ToString()) { }

            public async Task<bool> SendRequestAsync(string[] work, string id = Constants.DEFAULT_REQUEST_ID)
            {
                return await base.SendRequestAsync(id, work);
            }
            public RpcRequest BuildRequest(string[] work, string id = Constants.DEFAULT_REQUEST_ID)
            {
                return base.BuildRequest(id, work);
            }
        }

    }

