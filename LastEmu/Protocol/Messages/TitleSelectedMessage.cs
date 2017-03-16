using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TitleSelectedMessage : NetworkMessage
	{
		public const uint Id = 6366;

		public uint titleId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6366;
			}
		}

		public TitleSelectedMessage()
		{
		}

		public TitleSelectedMessage(uint titleId)
		{
			this.titleId = titleId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.titleId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.titleId);
		}
	}
}