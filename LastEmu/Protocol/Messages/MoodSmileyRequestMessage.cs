using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MoodSmileyRequestMessage : NetworkMessage
	{
		public const uint Id = 6192;

		public uint smileyId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6192;
			}
		}

		public MoodSmileyRequestMessage()
		{
		}

		public MoodSmileyRequestMessage(uint smileyId)
		{
			this.smileyId = smileyId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.smileyId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.smileyId);
		}
	}
}