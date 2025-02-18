using MineSharp.Core.Common;
using MineSharp.Data;
using MineSharp.Data.Protocol;

namespace MineSharp.Protocol.Packets.Clientbound.Configuration;

public class PluginMessagePacket : IPacket
{
    public PacketType Type => PacketType.CB_Configuration_CustomPayload;

    public string ChannelName { get; set; }
    public PacketBuffer Data { get; set; }

    public PluginMessagePacket(string channelName, PacketBuffer data)
    {
        this.ChannelName = channelName;
        this.Data = data;
    }

    public void Write(PacketBuffer buffer, MinecraftData version)
    {
        buffer.WriteString(this.ChannelName);
        buffer.WriteBytes(this.Data.GetBuffer());
    }

    public static IPacket Read(PacketBuffer buffer, MinecraftData version)
    {
        var channelName = buffer.ReadString();
        var clone = new PacketBuffer(buffer.ReadBytes((int)buffer.ReadableBytes));
        return new PluginMessagePacket(channelName, clone);
    }
}
