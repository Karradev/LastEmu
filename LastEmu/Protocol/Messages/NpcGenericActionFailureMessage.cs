using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NpcGenericActionFailureMessage : NetworkMessage
	{
		public const uint Id = 5900;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5900;
			}
		}

		public NpcGenericActionFailureMessage()
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