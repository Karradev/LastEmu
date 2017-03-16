using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuidedModeQuitRequestMessage : NetworkMessage
	{
		public const uint Id = 6092;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6092;
			}
		}

		public GuidedModeQuitRequestMessage()
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