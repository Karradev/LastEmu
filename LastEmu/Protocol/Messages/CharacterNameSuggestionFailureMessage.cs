using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterNameSuggestionFailureMessage : NetworkMessage
	{
		public const uint Id = 164;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)164;
			}
		}

		public CharacterNameSuggestionFailureMessage()
		{
		}

		public CharacterNameSuggestionFailureMessage(sbyte reason)
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