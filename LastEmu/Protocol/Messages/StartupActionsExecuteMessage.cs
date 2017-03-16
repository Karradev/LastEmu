using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class StartupActionsExecuteMessage : NetworkMessage
	{
		public const uint Id = 1302;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1302;
			}
		}

		public StartupActionsExecuteMessage()
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