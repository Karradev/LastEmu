using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class SelectedServerDataExtendedMessage : SelectedServerDataMessage
	{
		public const uint Id = 6469;

		public uint[] serverIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6469;
			}
		}

		public SelectedServerDataExtendedMessage()
		{
		}

		public SelectedServerDataExtendedMessage(uint serverId, string address, ushort port, bool canCreateNewCharacter, sbyte[] ticket, uint[] serverIds) : base(serverId, address, port, canCreateNewCharacter, ticket)
		{
			this.serverIds = serverIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.serverIds = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.serverIds[i] = reader.ReadVarUhShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.serverIds.Length));
			uint[] numArray = this.serverIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
		}
	}
}