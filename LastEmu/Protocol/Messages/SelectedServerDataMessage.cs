using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SelectedServerDataMessage : NetworkMessage
	{
		public const uint Id = 42;

		public uint serverId;

		public string address;

		public ushort port;

		public bool canCreateNewCharacter;

		public sbyte[] ticket;

		public override uint ProtocolId
		{
			get
			{
				return (uint)42;
			}
		}

		public SelectedServerDataMessage()
		{
		}

		public SelectedServerDataMessage(uint serverId, string address, ushort port, bool canCreateNewCharacter, sbyte[] ticket)
		{
			this.serverId = serverId;
			this.address = address;
			this.port = port;
			this.canCreateNewCharacter = canCreateNewCharacter;
			this.ticket = ticket;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.serverId = reader.ReadVarUhShort();
			this.address = reader.ReadUTF();
			this.port = reader.ReadUShort();
			this.canCreateNewCharacter = reader.ReadBoolean();
			ushort num = (ushort)reader.ReadVarInt();
			this.ticket = new sbyte[num];
			for (int i = 0; i < num; i++)
			{
				this.ticket[i] = reader.ReadSByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.serverId);
			writer.WriteUTF(this.address);
			writer.WriteUShort(this.port);
			writer.WriteBoolean(this.canCreateNewCharacter);
			writer.WriteVarInt((int)((int)this.ticket.Length));
			sbyte[] numArray = this.ticket;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteSByte(numArray[i]);
			}
		}
	}
}