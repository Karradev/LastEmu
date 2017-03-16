using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterDeletionErrorMessage : NetworkMessage
	{
		public const uint Id = 166;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)166;
			}
		}

		public CharacterDeletionErrorMessage()
		{
		}

		public CharacterDeletionErrorMessage(sbyte reason)
		{
			this.reason = reason;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.reason = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.reason);
		}
	}
}