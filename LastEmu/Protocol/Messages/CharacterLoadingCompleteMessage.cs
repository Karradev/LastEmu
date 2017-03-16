using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterLoadingCompleteMessage : NetworkMessage
	{
		public const uint Id = 6471;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6471;
			}
		}

		public CharacterLoadingCompleteMessage()
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