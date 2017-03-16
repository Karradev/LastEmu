using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayArenaSwitchToFightServerMessage : NetworkMessage
	{
		public const uint Id = 6575;

		public string address;

		public ushort port;

		public sbyte[] ticket;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6575;
			}
		}

		public GameRolePlayArenaSwitchToFightServerMessage()
		{
		}

		public GameRolePlayArenaSwitchToFightServerMessage(string address, ushort port, sbyte[] ticket)
		{
			this.address = address;
			this.port = port;
			this.ticket = ticket;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.address = reader.ReadUTF();
			this.port = reader.ReadUShort();
			ushort num = (ushort)reader.ReadVarInt();
			this.ticket = new sbyte[num];
			for (int i = 0; i < num; i++)
			{
				this.ticket[i] = reader.ReadSByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.address);
			writer.WriteUShort(this.port);
			writer.WriteVarInt((int)((int)this.ticket.Length));
			sbyte[] numArray = this.ticket;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteSByte(numArray[i]);
			}
		}
	}
}