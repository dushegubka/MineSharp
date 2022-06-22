﻿using MineSharp.Core.Types;

namespace MineSharp.Protocol.Packets.Clientbound.Login {
    public class DisconnectPacket : Packet {

        public Chat Reason { get; private set; }

        public DisconnectPacket() { }
        public DisconnectPacket(Chat chat) {
            this.Reason = chat;
        }

        public override async Task Handle(MinecraftClient client) {
            client.ForceDisconnect(Reason.JSON);
            await base.Handle(client);
        }

        public override void Read(PacketBuffer buffer) {
            this.Reason = buffer.ReadChat();
        }

        public override void Write(PacketBuffer buffer) {
            buffer.WriteChat(this.Reason);
        }
    }
}
