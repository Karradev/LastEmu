using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class StartupActionsListMessage : NetworkMessage
	{
		public const uint Id = 1301;

		public StartupActionAddObject[] actions;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1301;
			}
		}

		public StartupActionsListMessage()
		{
		}

		public StartupActionsListMessage(StartupActionAddObject[] actions)
		{
			this.actions = actions;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.actions = new StartupActionAddObject[num];
			for (int i = 0; i < num; i++)
			{
				this.actions[i] = new StartupActionAddObject();
				this.actions[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.actions.Length));
			StartupActionAddObject[] startupActionAddObjectArray = this.actions;
			for (int i = 0; i < (int)startupActionAddObjectArray.Length; i++)
			{
				startupActionAddObjectArray[i].Serialize(writer);
			}
		}
	}
}