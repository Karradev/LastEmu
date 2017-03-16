using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MoodSmileyResultMessage : NetworkMessage
	{
		public const uint Id = 6196;

		public sbyte resultCode;

		public uint smileyId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6196;
			}
		}

		public MoodSmileyResultMessage()
		{
		}

		public MoodSmileyResultMessage(sbyte resultCode, uint smileyId)
		{
			this.resultCode = resultCode;
			this.smileyId = smileyId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.resultCode = reader.ReadSByte();
			this.smileyId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.resultCode);
			writer.WriteVarShort((int)this.smileyId);
		}
	}
}