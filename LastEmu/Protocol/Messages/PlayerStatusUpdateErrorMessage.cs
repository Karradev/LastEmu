using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PlayerStatusUpdateErrorMessage : NetworkMessage
	{
		public const uint Id = 6385;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6385;
			}
		}

		public PlayerStatusUpdateErrorMessage()
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