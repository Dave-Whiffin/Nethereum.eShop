using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Nethereum.Commerce.Contracts.BusinessPartnerStorage.ContractDefinition
{


    public partial class BusinessPartnerStorageDeployment : BusinessPartnerStorageDeploymentBase
    {
        public BusinessPartnerStorageDeployment() : base(BYTECODE) { }
        public BusinessPartnerStorageDeployment(string byteCode) : base(byteCode) { }
    }

    public class BusinessPartnerStorageDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801561001057600080fd5b5060405162002445380380620024458339810160408190526100319161009f565b600080546001600160a01b03191633178082556040516001600160a01b039190911691907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e0908290a3600280546001600160a01b0319166001600160a01b03929092169190911790556100cd565b6000602082840312156100b0578081fd5b81516001600160a01b03811681146100c6578182fd5b9392505050565b61236880620000dd6000396000f3fe608060405234801561001057600080fd5b50600436106100b45760003560e01c806398ff9c541161007157806398ff9c5414610154578063b3e45d241461015c578063ba51c6d51461017c578063cfb519281461018f578063f2fde38b146101af578063f3ad65f4146101c2576100b4565b80635def1ee6146100b95780637e44e504146100ce57806385057a09146100f75780638da5cb5b1461010a5780638e5fc30b1461011f5780638f32d59b1461013f575b600080fd5b6100cc6100c7366004611e6e565b6101ca565b005b6100e16100dc366004611cca565b610667565b6040516100ee9190612272565b60405180910390f35b6100cc610105366004611d1b565b610b11565b610112610bf3565b6040516100ee9190611fbf565b61013261012d366004611cfa565b610c02565b6040516100ee9190612013565b610147610d2c565b6040516100ee9190611fd3565b610112610d3d565b61016f61016a366004611cca565b610d4c565b6040516100ee91906121f6565b6100cc61018a366004611da5565b611429565b6101a261019d366004611d1b565b611a9a565b6040516100ee9190611f2f565b6100cc6101bd366004611c6f565b611abc565b610112611ae9565b60408101516001600160a01b03166101fd5760405162461bcd60e51b81526004016101f490612046565b60405180910390fd5b610205611b53565b815161021090610667565b60408101519091506001600160a01b031661023057336080830152610270565b60808101516001600160a01b0316331461025c5760405162461bcd60e51b81526004016101f490612160565b6080808201516001600160a01b0316908301525b604080518082018252600f81526e476c6f62616c427053746f7261676560881b60208083019190915282518084018452600681526539b2b63632b960d11b81830152855193516000946102c69493909101611f8b565b60408051601f198184030181528282528051602091820120600154848401845260088552671cd95b1b195c925960c21b8584015292519094506001600160a01b03909216926325cf512d9261031e9286929101611f38565b60408051601f1981840301815290829052805160209091012086516001600160e01b031960e085901b16835261035692600401612005565b600060405180830381600087803b15801561037057600080fd5b505af1158015610384573d6000803e3d6000fd5b5050600154604080518082018252601181527039b2b63632b92232b9b1b934b83a34b7b760791b60208083019190915291516001600160a01b0390931694506325cf512d93506103d692869201611f38565b6040516020818303038152906040528051906020012085602001516040518363ffffffff1660e01b815260040161040e929190612005565b600060405180830381600087803b15801561042857600080fd5b505af115801561043c573d6000803e3d6000fd5b5050600154604080518082018252601481527361646d696e436f6e74726163744164647265737360601b60208083019190915291516001600160a01b039093169450635a2bf25a935061049192869201611f38565b60408051601f198184030181528282528051602090910120908701516001600160e01b031960e085901b1683526104ca92600401611fde565b600060405180830381600087803b1580156104e457600080fd5b505af11580156104f8573d6000803e3d6000fd5b50506001546040805180820182526008815267697341637469766560c01b60208083019190915291516001600160a01b039093169450633eba9ed2935061054192869201611f38565b6040516020818303038152906040528051906020012085606001516040518363ffffffff1660e01b8152600401610579929190611ff5565b600060405180830381600087803b15801561059357600080fd5b505af11580156105a7573d6000803e3d6000fd5b5050600154604080518082018252601081526f6372656174656442794164647265737360801b60208083019190915291516001600160a01b039093169450635a2bf25a93506105f892869201611f38565b6040516020818303038152906040528051906020012085608001516040518363ffffffff1660e01b8152600401610630929190611fde565b600060405180830381600087803b15801561064a57600080fd5b505af115801561065e573d6000803e3d6000fd5b50505050505050565b61066f611b53565b60006040518060400160405280600f81526020016e476c6f62616c427053746f7261676560881b8152506040518060400160405280600681526020016539b2b63632b960d11b815250846040516020016106cb93929190611f8b565b60408051601f198184030181528282528051602091820120600154848401845260088552671cd95b1b195c925960c21b8584015292519094506001600160a01b039092169263025ec81a926107239286929101611f38565b604051602081830303815290604052805190602001206040518263ffffffff1660e01b81526004016107559190611f2f565b60206040518083038186803b15801561076d57600080fd5b505afa158015610781573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506107a59190810190611ce2565b8252600154604080518082018252601181527039b2b63632b92232b9b1b934b83a34b7b760791b60208083019190915291516001600160a01b039093169263025ec81a926107f7928692909101611f38565b604051602081830303815290604052805190602001206040518263ffffffff1660e01b81526004016108299190611f2f565b60206040518083038186803b15801561084157600080fd5b505afa158015610855573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506108799190810190611ce2565b602080840191909152600154604080518082018252601481527361646d696e436f6e74726163744164647265737360601b8185015290516001600160a01b0390921692634c77e5ba926108d0928692909101611f38565b604051602081830303815290604052805190602001206040518263ffffffff1660e01b81526004016109029190611f2f565b60206040518083038186803b15801561091a57600080fd5b505afa15801561092e573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506109529190810190611c92565b6001600160a01b03908116604080850191909152600154815180830183526008815267697341637469766560c01b602080830191909152925191909316926317e7dd22926109a39286929101611f38565b604051602081830303815290604052805190602001206040518263ffffffff1660e01b81526004016109d59190611f2f565b60206040518083038186803b1580156109ed57600080fd5b505afa158015610a01573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250610a259190810190611cae565b15156060830152600154604080518082018252601081526f6372656174656442794164647265737360801b60208083019190915291516001600160a01b0390931692634c77e5ba92610a7b928692909101611f38565b604051602081830303815290604052805190602001206040518263ffffffff1660e01b8152600401610aad9190611f2f565b60206040518083038186803b158015610ac557600080fd5b505afa158015610ad9573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250610afd9190810190611c92565b6001600160a01b0316608083015250919050565b610b19610d2c565b610b355760405162461bcd60e51b81526004016101f4906120da565b60025460405163d9c4c15360e01b81526001600160a01b039091169063d9c4c15390610b65908490600401612013565b60206040518083038186803b158015610b7d57600080fd5b505afa158015610b91573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250610bb59190810190611c92565b600180546001600160a01b0319166001600160a01b03928316179081905516610bf05760405162461bcd60e51b81526004016101f49061210f565b50565b6000546001600160a01b031690565b6040805160208082528183019092526060918291906020820181803883390190505090506000805b6020811015610c80576008810260020a86026001600160f81b0319811615610c775780848481518110610c5957fe5b60200101906001600160f81b031916908160001a9053506001909201915b50600101610c2a565b50600081851180610c8f575084155b15610c9b575080610ca2565b5060001984015b6060816040519080825280601f01601f191660200182016040528015610ccf576020820181803883390190505b50905060005b82811015610d1f57848181518110610ce957fe5b602001015160f81c60f81b828281518110610d0057fe5b60200101906001600160f81b031916908160001a905350600101610cd5565b5093505050505b92915050565b6000546001600160a01b0316331490565b6001546001600160a01b031681565b610d54611b81565b60006040518060400160405280600f81526020016e476c6f62616c427053746f7261676560881b8152506040518060400160405280600581526020016406553686f760dc1b81525084604051602001610daf93929190611f8b565b60408051601f198184030181528282528051602091820120600154848401845260078552661954da1bdc125960ca1b8584015292519094506001600160a01b039092169263025ec81a92610e069286929101611f38565b604051602081830303815290604052805190602001206040518263ffffffff1660e01b8152600401610e389190611f2f565b60206040518083038186803b158015610e5057600080fd5b505afa158015610e64573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250610e889190810190611ce2565b8252600154604080518082018252601081526f32a9b437b82232b9b1b934b83a34b7b760811b60208083019190915291516001600160a01b039093169263025ec81a92610ed9928692909101611f38565b604051602081830303815290604052805190602001206040518263ffffffff1660e01b8152600401610f0b9190611f2f565b60206040518083038186803b158015610f2357600080fd5b505afa158015610f37573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250610f5b9190810190611ce2565b602080840191909152600154604080518082018252601981527870757263686173696e67436f6e74726163744164647265737360381b8185015290516001600160a01b0390921692634c77e5ba92610fb7928692909101611f38565b604051602081830303815290604052805190602001206040518263ffffffff1660e01b8152600401610fe99190611f2f565b60206040518083038186803b15801561100157600080fd5b505afa158015611015573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506110399190810190611c92565b6001600160a01b03908116604080850191909152600154815180830183526008815267697341637469766560c01b602080830191909152925191909316926317e7dd229261108a9286929101611f38565b604051602081830303815290604052805190602001206040518263ffffffff1660e01b81526004016110bc9190611f2f565b60206040518083038186803b1580156110d457600080fd5b505afa1580156110e8573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525061110c9190810190611cae565b15156060830152600154604080518082018252601081526f6372656174656442794164647265737360801b60208083019190915291516001600160a01b0390931692634c77e5ba92611162928692909101611f38565b604051602081830303815290604052805190602001206040518263ffffffff1660e01b81526004016111949190611f2f565b60206040518083038186803b1580156111ac57600080fd5b505afa1580156111c0573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506111e49190810190611c92565b6001600160a01b039081166080840152600154604080518082018252601081526f1c5d5bdd1954da59db995c90dbdd5b9d60821b6020808301919091529151929093169263ac0945539261123b9286929101611f38565b604051602081830303815290604052805190602001206040518263ffffffff1660e01b815260040161126d9190611f2f565b60206040518083038186803b15801561128557600080fd5b505afa158015611299573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506112bd9190810190611ce2565b60ff1660a083018190526040805182815260208084028201019091528180156112f0578160200160208202803883390190505b5060c084015260005b81811015611421576000836040518060400160405280600381526020016207173760ec1b8152508360405160200161133393929190611f5e565b60408051601f198184030181529082905280516020918201206001549093506001600160a01b031691634c77e5ba9161136e91859101611f2f565b604051602081830303815290604052805190602001206040518263ffffffff1660e01b81526004016113a09190611f2f565b60206040518083038186803b1580156113b857600080fd5b505afa1580156113cc573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506113f09190810190611c92565b8560c00151838151811061140057fe5b6001600160a01b0390921660209283029190910190910152506001016112f9565b505050919050565b60c08101515160408201516001600160a01b03166114595760405162461bcd60e51b81526004016101f4906121ac565b806114765760405162461bcd60e51b81526004016101f49061208c565b61147e611b81565b825161148990610d4c565b60408101519091506001600160a01b03166114a9573360808401526114e9565b60808101516001600160a01b031633146114d55760405162461bcd60e51b81526004016101f490612160565b6080808201516001600160a01b0316908401525b604080518082018252600f81526e476c6f62616c427053746f7261676560881b60208083019190915282518084018452600581526406553686f760dc1b818301528651935160009461153e9493909101611f8b565b60408051601f198184030181528282528051602091820120600154848401845260078552661954da1bdc125960ca1b8584015292519094506001600160a01b03909216926325cf512d926115959286929101611f38565b60408051601f1981840301815290829052805160209091012087516001600160e01b031960e085901b1683526115cd92600401612005565b600060405180830381600087803b1580156115e757600080fd5b505af11580156115fb573d6000803e3d6000fd5b5050600154604080518082018252601081526f32a9b437b82232b9b1b934b83a34b7b760811b60208083019190915291516001600160a01b0390931694506325cf512d935061164c92869201611f38565b6040516020818303038152906040528051906020012086602001516040518363ffffffff1660e01b8152600401611684929190612005565b600060405180830381600087803b15801561169e57600080fd5b505af11580156116b2573d6000803e3d6000fd5b5050600154604080518082018252601981527870757263686173696e67436f6e74726163744164647265737360381b60208083019190915291516001600160a01b039093169450635a2bf25a935061170c92869201611f38565b60408051601f198184030181528282528051602090910120908801516001600160e01b031960e085901b16835261174592600401611fde565b600060405180830381600087803b15801561175f57600080fd5b505af1158015611773573d6000803e3d6000fd5b50506001546040805180820182526008815267697341637469766560c01b60208083019190915291516001600160a01b039093169450633eba9ed293506117bc92869201611f38565b6040516020818303038152906040528051906020012086606001516040518363ffffffff1660e01b81526004016117f4929190611ff5565b600060405180830381600087803b15801561180e57600080fd5b505af1158015611822573d6000803e3d6000fd5b5050600154604080518082018252601081526f6372656174656442794164647265737360801b60208083019190915291516001600160a01b039093169450635a2bf25a935061187392869201611f38565b6040516020818303038152906040528051906020012086608001516040518363ffffffff1660e01b81526004016118ab929190611fde565b600060405180830381600087803b1580156118c557600080fd5b505af11580156118d9573d6000803e3d6000fd5b5050600154604080518082018252601081526f1c5d5bdd1954da59db995c90dbdd5b9d60821b60208083019190915291516001600160a01b03909316945063dde5b9d5935061192a92869201611f38565b60405160208183030381529060405280519060200120856040518363ffffffff1660e01b815260040161195e929190612005565b600060405180830381600087803b15801561197857600080fd5b505af115801561198c573d6000803e3d6000fd5b506000925050505b83811015611a93576000826040518060400160405280600381526020016207173760ec1b815250836040516020016119ce93929190611f5e565b60408051601f198184030181529082905280516020918201206001549093506001600160a01b031691635a2bf25a91611a0991859101611f2f565b604051602081830303815290604052805190602001208860c001518581518110611a2f57fe5b60200260200101516040518363ffffffff1660e01b8152600401611a54929190611fde565b600060405180830381600087803b158015611a6e57600080fd5b505af1158015611a82573d6000803e3d6000fd5b505060019093019250611994915050565b5050505050565b80516000908290611aaf575060009050611ab7565b505060208101515b919050565b611ac4610d2c565b611ae05760405162461bcd60e51b81526004016101f4906120da565b610bf081611af8565b6002546001600160a01b031681565b600080546040516001600160a01b03808516939216917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e091a3600080546001600160a01b0319166001600160a01b0392909216919091179055565b6040805160a08101825260008082526020820181905291810182905260608101829052608081019190915290565b6040805160e08101825260008082526020820181905291810182905260608082018390526080820183905260a082019290925260c081019190915290565b8035610d268161230f565b600082601f830112611bda578081fd5b813567ffffffffffffffff811115611bf0578182fd5b6020808202611c008282016122b8565b83815293508184018583018287018401881015611c1c57600080fd5b600092505b84831015611c48578035611c348161230f565b825260019290920191908301908301611c21565b505050505092915050565b8035610d2681612324565b803560ff81168114610d2657600080fd5b600060208284031215611c80578081fd5b8135611c8b8161230f565b9392505050565b600060208284031215611ca3578081fd5b8151611c8b8161230f565b600060208284031215611cbf578081fd5b8151611c8b81612324565b600060208284031215611cdb578081fd5b5035919050565b600060208284031215611cf3578081fd5b5051919050565b60008060408385031215611d0c578081fd5b50508035926020909101359150565b60006020808385031215611d2d578182fd5b823567ffffffffffffffff80821115611d44578384fd5b81850186601f820112611d55578485fd5b8035925081831115611d65578485fd5b611d77601f8401601f191685016122b8565b91508282528684848301011115611d8c578485fd5b8284820185840137509081019091019190915292915050565b600060208284031215611db6578081fd5b813567ffffffffffffffff80821115611dcd578283fd5b81840160e08187031215611ddf578384fd5b611de960e06122b8565b92508035835260208101356020840152611e068660408301611bbf565b6040840152611e188660608301611c53565b6060840152611e2a8660808301611bbf565b6080840152611e3c8660a08301611c5e565b60a084015260c081013582811115611e52578485fd5b611e5e87828401611bca565b60c0850152509195945050505050565b600060a08284031215611e7f578081fd5b611e8960a06122b8565b82358152602083013560208201526040830135611ea58161230f565b60408201526060830135611eb881612324565b60608201526080830135611ecb8161230f565b60808201529392505050565b6001600160a01b03169052565b6000815180845260208401935060208301825b82811015611f1e5781516001600160a01b0316865260209586019590910190600101611ef7565b5093949350505050565b60ff169052565b90815260200190565b60008382528251611f508160208501602087016122df565b919091016020019392505050565b60008482528351611f768160208501602088016122df565b60209201918201929092526040019392505050565b60008451611f9d8184602089016122df565b8451908301611fb08282602089016122df565b01928352505060200192915050565b6001600160a01b0391909116815260200190565b901515815260200190565b9182526001600160a01b0316602082015260400190565b9182521515602082015260400190565b918252602082015260400190565b60006020825282518060208401526120328160408501602087016122df565b601f01601f19169190910160400192915050565b60208082526026908201527f4d757374207370656369667920616e2061646d696e20636f6e7472616374206160408201526564647265737360d01b606082015260800190565b6020808252602e908201527f4d7573742073706563696679206174206c65617374206f6e652071756f74652060408201526d7369676e6572206164647265737360901b606082015260800190565b6020808252818101527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604082015260600190565b60208082526031908201527f436f756c64206e6f742066696e6420457465726e616c53746f72616765206164604082015270647265737320696e20726567697374727960781b606082015260800190565b6020808252602c908201527f4f6e6c7920637265617465644279416464726573732063616e206368616e676560408201526b081d1a1a5cc81c9958dbdc9960a21b606082015260800190565b6020808252602a908201527f4d757374207370656369667920612070757263686173696e6720636f6e7472616040820152696374206164647265737360b01b606082015260800190565b600060208252825160208301526020830151604083015260018060a01b036040840151166060830152606083015115156080830152608083015161223d60a0840182611ed7565b5060a083015161225060c0840182611f28565b5060c083015160e08084015261226a610100840182611ee4565b949350505050565b81518152602080830151908201526040808301516001600160a01b0390811691830191909152606080840151151590830152608092830151169181019190915260a00190565b60405181810167ffffffffffffffff811182821017156122d757600080fd5b604052919050565b60005b838110156122fa5781810151838201526020016122e2565b83811115612309576000848401525b50505050565b6001600160a01b0381168114610bf057600080fd5b8015158114610bf057600080fdfea2646970667358221220f55d617afcf29a0d623e6ac1d02c0aaf6e48378e88ac950be4fea1a1b4da0f6564736f6c63430006010033";
        public BusinessPartnerStorageDeploymentBase() : base(BYTECODE) { }
        public BusinessPartnerStorageDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "contractAddressOfRegistry", 1)]
        public virtual string ContractAddressOfRegistry { get; set; }
    }

    public partial class AddressRegistryFunction : AddressRegistryFunctionBase { }

    [Function("addressRegistry", "address")]
    public class AddressRegistryFunctionBase : FunctionMessage
    {

    }

    public partial class Bytes32ToStringFunction : Bytes32ToStringFunctionBase { }

    [Function("bytes32ToString", "string")]
    public class Bytes32ToStringFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "x", 1)]
        public virtual byte[] X { get; set; }
        [Parameter("uint256", "truncateToLength", 2)]
        public virtual BigInteger TruncateToLength { get; set; }
    }

    public partial class ConfigureFunction : ConfigureFunctionBase { }

    [Function("configure")]
    public class ConfigureFunctionBase : FunctionMessage
    {
        [Parameter("string", "nameOfEternalStorage", 1)]
        public virtual string NameOfEternalStorage { get; set; }
    }

    public partial class EternalStorageFunction : EternalStorageFunctionBase { }

    [Function("eternalStorage", "address")]
    public class EternalStorageFunctionBase : FunctionMessage
    {

    }

    public partial class GetEshopFunction : GetEshopFunctionBase { }

    [Function("getEshop", typeof(GetEshopOutputDTO))]
    public class GetEshopFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "eShopId", 1)]
        public virtual byte[] EShopId { get; set; }
    }

    public partial class GetSellerFunction : GetSellerFunctionBase { }

    [Function("getSeller", typeof(GetSellerOutputDTO))]
    public class GetSellerFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "sellerId", 1)]
        public virtual byte[] SellerId { get; set; }
    }

    public partial class IsOwnerFunction : IsOwnerFunctionBase { }

    [Function("isOwner", "bool")]
    public class IsOwnerFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class SetEshopFunction : SetEshopFunctionBase { }

    [Function("setEshop")]
    public class SetEshopFunctionBase : FunctionMessage
    {
        [Parameter("tuple", "eShop", 1)]
        public virtual Eshop EShop { get; set; }
    }

    public partial class SetSellerFunction : SetSellerFunctionBase { }

    [Function("setSeller")]
    public class SetSellerFunctionBase : FunctionMessage
    {
        [Parameter("tuple", "seller", 1)]
        public virtual Seller Seller { get; set; }
    }

    public partial class StringToBytes32Function : StringToBytes32FunctionBase { }

    [Function("stringToBytes32", "bytes32")]
    public class StringToBytes32FunctionBase : FunctionMessage
    {
        [Parameter("string", "source", 1)]
        public virtual string Source { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class AddressRegistryOutputDTO : AddressRegistryOutputDTOBase { }

    [FunctionOutput]
    public class AddressRegistryOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class Bytes32ToStringOutputDTO : Bytes32ToStringOutputDTOBase { }

    [FunctionOutput]
    public class Bytes32ToStringOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class EternalStorageOutputDTO : EternalStorageOutputDTOBase { }

    [FunctionOutput]
    public class EternalStorageOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetEshopOutputDTO : GetEshopOutputDTOBase { }

    [FunctionOutput]
    public class GetEshopOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "eShop", 1)]
        public virtual Eshop EShop { get; set; }
    }

    public partial class GetSellerOutputDTO : GetSellerOutputDTOBase { }

    [FunctionOutput]
    public class GetSellerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "seller", 1)]
        public virtual Seller Seller { get; set; }
    }

    public partial class IsOwnerOutputDTO : IsOwnerOutputDTOBase { }

    [FunctionOutput]
    public class IsOwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }





    public partial class StringToBytes32OutputDTO : StringToBytes32OutputDTOBase { }

    [FunctionOutput]
    public class StringToBytes32OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "result", 1)]
        public virtual byte[] Result { get; set; }
    }


}
