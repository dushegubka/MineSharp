using MineSharp.Core.Common.Protocol;
using NLog;
using System.Diagnostics.CodeAnalysis;

namespace MineSharp.Data.Protocol;

public class ProtocolProvider
{
    private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
    
    private readonly ProtocolVersion _version;

    private Dictionary<PacketFlow, Dictionary<GameState, Dictionary<int, PacketType>>> _idToTypeMap;
    
    internal ProtocolProvider(ProtocolVersion version)
    {
        this._version = version;
        
        this._idToTypeMap = new Dictionary<PacketFlow, Dictionary<GameState, Dictionary<int, PacketType>>>();
        foreach (var flow in Enum.GetValues<PacketFlow>())
        {
            this._idToTypeMap.Add(flow, new Dictionary<GameState, Dictionary<int, PacketType>>());
            foreach (var state in Enum.GetValues<GameState>())
                this._idToTypeMap[flow].Add(state, new Dictionary<int, PacketType>());
        }
        
        foreach (var kvp in this._version.PacketIds)
        {
            var intVal = (int)kvp.Key;
            var state = (GameState)(sbyte)(intVal >> 8 & 0xFF);
            var flow = (PacketFlow)(sbyte)(intVal >> 16 & 0xFF);
            this._idToTypeMap[flow][state].Add(kvp.Value, kvp.Key);
        }
    }

    public int GetPacketId(PacketType type)
        => this._version.PacketIds[type];

    public PacketType FromPacketId(PacketFlow flow, GameState state, int id)
    {
        try
        {
            var direction = this._idToTypeMap[flow];
            var gameState = direction[state];
            var type = gameState[id];
            return type;
        } catch (KeyNotFoundException)
        {
            Logger.Debug($"Could not map {flow} -> {state} -> {id} to PacketType.");
            throw;
        }
    }
}
