using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterNameSuggestionRequestMessage : NetworkMessage
	{
		public const uint Id = 162;

		public override uint ProtocolId
		{
			get
			{
				return (uint)162;
			}
		}

		public CharacterNameSuggestionRequestMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}