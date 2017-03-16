using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterSelectedForceReadyMessage : NetworkMessage
	{
		public const uint Id = 6072;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6072;
			}
		}

		public CharacterSelectedForceReadyMessage()
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