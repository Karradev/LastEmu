using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectGroundRemovedMessage : NetworkMessage
	{
		public const uint Id = 3014;

		public uint cell;

		public override uint ProtocolId
		{
			get
			{
				return (uint)3014;
			}
		}

		public ObjectGroundRemovedMessage()
		{
		}

		public ObjectGroundRemovedMessage(uint cell)
		{
			this.cell = cell;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.cell = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.cell);
		}
	}
}