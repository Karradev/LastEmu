using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ReloginTokenRequestMessage : NetworkMessage
	{
		public const uint Id = 6540;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6540;
			}
		}

		public ReloginTokenRequestMessage()
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