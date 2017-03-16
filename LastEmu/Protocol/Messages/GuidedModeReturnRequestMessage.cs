using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuidedModeReturnRequestMessage : NetworkMessage
	{
		public const uint Id = 6088;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6088;
			}
		}

		public GuidedModeReturnRequestMessage()
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