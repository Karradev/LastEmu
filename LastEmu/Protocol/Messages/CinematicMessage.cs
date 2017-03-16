using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CinematicMessage : NetworkMessage
	{
		public const uint Id = 6053;

		public uint cinematicId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6053;
			}
		}

		public CinematicMessage()
		{
		}

		public CinematicMessage(uint cinematicId)
		{
			this.cinematicId = cinematicId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.cinematicId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.cinematicId);
		}
	}
}