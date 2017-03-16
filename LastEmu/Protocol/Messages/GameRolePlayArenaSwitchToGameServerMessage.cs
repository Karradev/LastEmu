using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayArenaSwitchToGameServerMessage : NetworkMessage
	{
		public const uint Id = 6574;

		public bool validToken;

		public sbyte[] ticket;

		public short homeServerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6574;
			}
		}

		public GameRolePlayArenaSwitchToGameServerMessage()
		{
		}

		public GameRolePlayArenaSwitchToGameServerMessage(bool validToken, sbyte[] ticket, short homeServerId)
		{
			this.validToken = validToken;
			this.ticket = ticket;
			this.homeServerId = homeServerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.validToken = reader.ReadBoolean();
			ushort num = (ushort)reader.ReadVarInt();
			this.ticket = new sbyte[num];
			for (int i = 0; i < num; i++)
			{
				this.ticket[i] = reader.ReadSByte();
			}
			this.homeServerId = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.validToken);
			writer.WriteVarInt((int)((int)this.ticket.Length));
			sbyte[] numArray = this.ticket;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteSByte(numArray[i]);
			}
			writer.WriteShort(this.homeServerId);
		}
	}
}